using Liga.Api.DTOs;
using Liga.Api.Entities;
using Liga.Api.Repositories;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Liga.Api.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public async Task<ResponseBase> Login(UsuarioLoginDto loginDto)
        {
            try
            {
                var usuario = await _usuarioRepository.GetByEmail(loginDto.Email);
                if (usuario == null)
                    throw new Exception("Usuario no existe");

                var hashedPassword = HashPassword(loginDto.Password);
                if (usuario.Password != hashedPassword)
                    throw new Exception("Contraseña incorrecta");

                var response = new ResponseBase();
                response.Content = usuario.Id;
                response.Success = true;
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task RegistrarUsuario(Usuario usuario)
        {
            usuario.Password = HashPassword(usuario.Password);
            await _usuarioRepository.CreateUser(usuario);
        }

        private string HashPassword(string password)
        {
            using var sha256Hash = SHA256.Create();

            // ComputeHash - returns byte array
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convert byte array to a string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")).ToString();
            }

            return builder.ToString();
        }
    }
}
