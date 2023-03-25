using API_Tareadef.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System;
using Newtonsoft.Json;
using Microsoft.OpenApi.Models;

namespace API_Tareadef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Historial_ClinicoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Historial_Clinico nuevo_historial)
        {
            if (nuevo_historial != null && !string.IsNullOrEmpty(nuevo_historial.Tratamiento))
            {
                var response = new ExResponse2
                {
                    Mensaje = $"Funca, {nuevo_historial.Tratamiento}"
                };
                string jsonString1 = JsonConvert.SerializeObject(nuevo_historial);//JSON a API deserealizar, API a JSON serealizar
                string path1 = @".\\Recursos\\HistorialJson.json";
                using (var tw = new StreamWriter(path1, true)) { tw.WriteLine(jsonString1.ToString() + "\r\n"); tw.Close(); }
                using (var testw = new StreamReader(path1, true))
                {
                    Console.WriteLine(testw.ReadLine());
                    Console.ReadLine();
                    testw.Close();
                }
                return Ok(response);
            }
            else
            {

                return BadRequest();
            }
            //JSON_object jSON = new JSON_object("okay", nuevo_paciente);
            /*string jsonString = JsonConvert.SerializeObject(nuevo_paciente);//JSON a API deserealizar, API a JSON serealizar
            string path = @".\\Recursos\\PacienteJson.json";
            using (var tw = new StreamWriter(path, true)) { tw.WriteLine(nuevo_paciente.ToString() + "\r\n"); tw.Close(); }
            using (var testw = new StreamReader(path, true)) 
            { 
                Console.WriteLine(testw.ReadLine());
                Console.ReadLine();
                testw.Close(); 
            }
            return Ok(nuevo_paciente);*/
        }
        /*[HttpDelete("eliminar_paciente")]
        public async Task<ActionResult<JSON_object>> eliminar_Paciente(Paciente eliminado_paciente)
        {
            JSON_object jSON = new JSON_object("okay", eliminado_paciente);

            

            int CedulaKey = eliminado_paciente.Cedula;

            string fileName = "PacienteJson.json";
            string path = @".\\Recursos\\PacienteJson.json";

            //string jsonContent = File.ReadAllText(path);

            using (var testw = new StreamReader(path, true))
            {
                //testw.ReadLine();
                Console.WriteLine(testw.ReadLine());
                Console.ReadLine();
                testw.Close();
            }


            return Ok(jSON);
        }
        [HttpPut("modificar_paciente")]
        public async Task<ActionResult<JSON_object>> modificar_Paciente(Paciente modificado_paciente)
        {
            JSON_object jSON = new JSON_object("okay", modificado_paciente);
            return Ok(jSON);
        }
        [HttpGet("mostrar_paciente")]
        public async Task<ActionResult<JSON_object>> mostrar_Paciente(Paciente paciente_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", paciente_mostrado); 
            return Ok(jSON);
        }*/

    }
    public class ExResponse2
    {
        public string Mensaje { get; set; }
    }
}

