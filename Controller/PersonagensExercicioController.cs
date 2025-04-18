using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgAPI.Models.Enums;
using RpgAPI.Models;

namespace RpgAPI.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            //Colar os objetos da lista do chat aqui
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        //MÉTODOS GET
        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome){

            Personagem pBusca = personagens.Find(p => p.Nome == nome);
            
            if (pBusca != null){
                return Ok(pBusca);
            }
            else{
                return NotFound(new{ message = "Personagem não Encontrado"});
            }

        }

        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago(){
            List<Personagem> listCavaleiros = personagens.FindAll(p => p.Classe == ClasseEnum.Cavaleiro);
            personagens.RemoveAll(p => listCavaleiros.Contains(p));
            personagens.OrderByDescending(p => p.PontosVida).ToList();
            return Ok(personagens);
        }

        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas(){
            return Ok("Quantidade de personagens: " + personagens.Count() + " Soma das inteligências: " + personagens.Sum(p => p.Inteligencia));
        }
        
        [HttpGet("GetByClasse/{classe}")]
        public IActionResult GetByClasse(ClasseEnum classe){
            List<Personagem> lClasse = personagens.FindAll(p => p.Classe == classe);
            return Ok(lClasse);
        }
        
        //MÉTODOS POST
        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem novoPersonagem){
            if(novoPersonagem.Defesa < 10 || novoPersonagem.Inteligencia > 30){
                return BadRequest("Esses valores não são válidos para adicionar o personagem");
            }
            else{
                personagens.Add(novoPersonagem);
                return Ok(novoPersonagem);
            }
        }
    
        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem novoPersonagem){
            if(novoPersonagem.Classe == ClasseEnum.Mago && novoPersonagem.Inteligencia < 35){
                return BadRequest("Um mago é mais inteligente do que isso!");
            }
            else{
                personagens.Add(novoPersonagem);
                return Ok(novoPersonagem);
            }
        }
        //MÉTODOS PUT
        //MÉTODOS DELETE
        
    }
}