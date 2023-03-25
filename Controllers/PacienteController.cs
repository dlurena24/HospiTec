﻿using API_Tareadef.Models;
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
    public class PacienteController : ControllerBase
    {
        [HttpPost("agregar_paciente")]
        public IActionResult Post([FromBody] Paciente nuevo_paciente)
        {
            JSON_object jSON = new JSON_object("okay", nuevo_paciente);
            string jsonString = JsonConvert.SerializeObject(nuevo_paciente);//JSON a API deserealizar, API a JSON serealizar
            Console.WriteLine(jsonString);
            string fileName = "PacienteJson.json";
            string path = @".\\Recursos\\PacienteJson.json";
            using (var tw = new StreamWriter(path, true)) { tw.WriteLine(jsonString.ToString() + "\r\n"); tw.Close(); }
            using (var testw = new StreamReader(path, true)) 
            { 
                //testw.ReadLine();
                Console.WriteLine(testw.ReadLine());
                Console.ReadLine();
                testw.Close(); 
            }
            return Ok(jSON);
        }
        [HttpDelete("eliminar_paciente")]
        public IActionResult Delete([FromBody] Paciente eliminado_paciente)
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
        public IActionResult Get([FromBody] Paciente modificado_paciente)
        {
            JSON_object jSON = new JSON_object("okay", modificado_paciente);
            return Ok(jSON);
        }
        [HttpGet("mostrar_paciente")]
        public async Task<ActionResult<JSON_object>> mostrar_Paciente(Paciente paciente_mostrado)
        {
            JSON_object jSON = new JSON_object("okay", paciente_mostrado); 
            return Ok(jSON);
        }

    }
}
