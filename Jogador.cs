using System;

namespace jogador
{
    public class Jogador
    {
        public string Nome {get; set;}
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura  { get; set; }
        public float Peso { get; set; }
        public DateTime Nascimento { get; set; }
        
        public int CalcularIdade(){
            
            
            
            int AnoAtual= Int32.Parse( DateTime.Now.ToString().Split("/")[2].Split(" ")[0] );            
            int AnoNascimento = Int32.Parse( Nascimento.ToString().Split("/")[2].Split(" ")[0] );

            Idade = AnoAtual - AnoNascimento;
            
            return Idade; 
        }

            
            public string VerificarAposentadoria(){

                CalcularIdade();
                string Retorno = "";
                if(Idade >= 35 && Posicao == "Atacante"){
                    Retorno = "\nO atacante pode se aposentar";
                }else if(Idade >= 38 && Posicao == "Meio Campo"){
                    Retorno = "\nO meio campista pode se aposentar";
                }else if(Idade >= 40 && Posicao == "Defensor"){
                    Retorno = "\nO Defensor pode se aposentar";
                }else{
                    Retorno = "\n O jogador não tem idade sulficiente para se aposentar tendo de idade ";
                }
                return Retorno;
            }
        
     
        public string MostrarDados(){
            return $" Aqui está as informações digitadas: \n Nome: {Nome} \n Posição: {Posicao} \n Data de nascimento: {Nascimento} \n Nacionalidade: {Nacionalidade} \n Altura: {Altura} \n Peso: {Peso}";
        }
    }
}