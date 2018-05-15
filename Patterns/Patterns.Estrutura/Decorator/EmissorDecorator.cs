using Patterns.Estrutura.Decorator.Interfaces;
using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Patterns.Estrutura.Decorator
{
    public abstract class EmissorDecorator : IEmissor
    {
        private readonly IEmissor emissor;

        public EmissorDecorator(IEmissor _emissor)
        {
            emissor = _emissor;
        }

        public IEmissor ObterEmissor()
        {
            return emissor;
        }

        public static string ComprimirMensagem(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }

        public static string CriptografarMensagem(string texto)
        {
            char[] arr = texto.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public abstract void Envia(string mensagem);
    }
}