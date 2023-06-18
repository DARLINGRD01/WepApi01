using Microsoft.AspNetCore.Mvc;
using NetCoreYoutube.Models;

namespace NetCoreYoutube.Controllers
{

    [ApiController]
    [Route("Cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listaCliente()
        {
            List<Cliente> clientes = new List<Cliente>

            {

              new Cliente
              {
                 id = "1"
                , correo = "google@gmail.com"
                , edad = "12"
                ,nombre = "fulano "
              },


              new Cliente
              {
                 id = "2"
                , correo = "google@gmail2.com"
                , edad = "12"
                ,nombre = "fulanito"
              }
            };

            return clientes;
        }

        [HttpGet]
        [Route("listarxid")]
        public dynamic listaClienteID(int cod)
        {

           
              return new Cliente

              {
                 id = cod.ToString()
                , correo = "google@gmail.com"
                , edad = "12"
                ,nombre = "fulano "

             };
        }

        [HttpPost]
        [Route("Guardar")]
        public dynamic guardarCliente (Cliente cliente)
        {
            cliente.id = "3";   

            return new
            { 
            success = true,
            message = "cliente registrado",
            Result = cliente 
            
            };

        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic EliminarCliente(Cliente cliente)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;


            if (token == "darling") 
            {
                return new
                {
                    success = true,
                    message = "cliente  Fallindo",
                    Result = ""

                };
             }

            else 
            {
                return new
                {
                    success = true,
                    message = "cliente error",
                    Result = cliente
                };
            }

        }


    }
}
    