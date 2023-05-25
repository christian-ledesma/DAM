using Liga.Api.DTOs;
using Liga.Api.Entities;
using Liga.Api.Repositories.Interfaces;
using Liga.Api.Services.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Liga.Api.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public async Task ActualizarUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.Password != null)
                {
                    usuario.Password = HashPassword(usuario.Password);
                }
                await _usuarioRepository.UpdateUser(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UsuarioDataDto> Get(string email)
        {
            var usuario = await _usuarioRepository.GetByEmail(email);
            var usuarioData = new UsuarioDataDto
            {
                Id = usuario.Id,
                Email = email,
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                ImagenBytes = usuario.ImagenBytes,
            };

            return usuarioData;
        }

        public async Task<UsuarioLoginResponse> Login(UsuarioLoginDto loginDto)
        {
            try
            {
                var usuario = await _usuarioRepository.GetByEmail(loginDto.Email);
                if (usuario == null)
                    throw new Exception("Usuario no existe");

                var hashedPassword = HashPassword(loginDto.Password);
                if (usuario.Password != hashedPassword)
                    throw new Exception("Contraseña incorrecta");

                var response = new UsuarioLoginResponse
                {
                    Id = usuario.Id,
                    Nombre = usuario.Nombre,
                    Apellidos = usuario.Apellidos,
                    Email = usuario.Email,
                    ImagenBytes = usuario.ImagenBytes,
                    Admin = usuario.Admin,
                    Success = true
                };
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task RegistrarUsuario(Usuario usuario)
        {
            try
            {
                usuario.Password = HashPassword(usuario.Password);
                await _usuarioRepository.CreateUser(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string HashPassword(string password)
        {
            using var sha256Hash = SHA256.Create();

            // CIFRAMOS CONTRASEÑA PARA MAYOR SEGURIDAD
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")).ToString();
            }

            return builder.ToString();
        }
    }
}
