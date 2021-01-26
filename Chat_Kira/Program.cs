
using System;



namespace Chat_Kira
{
    class Program
    {
        static void Main(string[] args)
        {
            string conver = "Welcome, Benvindo!";
            string keyword;
            string lista;
            string word;

            //boa vindas ao Sistema
            Console.WriteLine("===========================================");
            Console.WriteLine(conver);

            Console.WriteLine("===========================================");

            Console.Write(" Palavra Chave: ");
            keyword = Convert.ToString(Console.ReadLine());

            //Verificar se é um administrador
            if (keyword == "System Call" || keyword == "System call" || keyword == "system Call" || keyword == "system call" || keyword == "Private Void" || keyword == "Private void" || keyword == "private void" || keyword == "Release Recollection" || keyword == "release recollection" || keyword == "Release" || keyword == "Recolection")
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("BENVINDO AO SISTEMA - ADMIN ");
                Console.WriteLine("DADOS DO LOGIN: ADMIN - AK HYDRA DEV");
                Console.WriteLine("===========================================");

                Console.WriteLine("Em que Area Desejas atuar ADMIN AK?\n Dashboard \n Publicações \n Jogos ");
                Console.WriteLine("=========================================");
                Console.Write("R: ");
                word = Convert.ToString(Console.ReadLine());
                if (word == "Dashboard" || word == "dashboard" || word == "Dash" || word == "Painel Admin" || word == "Painel")
                {
                    Console.WriteLine("O que Desejas ADMIN AK?");
                    Console.WriteLine(" 1 - Ajuda");
                    Console.WriteLine(" 2 - Cadastrar");
                    Console.WriteLine(" 3 - Consultar");
                    Console.WriteLine("=========================================");
                    //Resposta 
                    Console.Write("R: ");
                    word = Convert.ToString(Console.ReadLine());

                    switch (word)
                    {
                        //Caso escolha a Soma (+)
                        case "Ajuda":

                            Console.WriteLine("=======================AJUDA==================");
                            Console.WriteLine(" Manual de Instrução: \n Lorem ipsum dolor sit amet consectetur adipisicing elit. Illum, tenetur. Saepe, consectetur quisquam. Voluptatem velit asperiores praesentium nemo quod reiciendis, et autem dicta cumque incidunt obcaecati suscipit laborum quia animi aspernatur totam illo" +
   " soluta mollitia quas itaque consectetur ? Quas illum, culpa dolore corporis dolores provident inventore nam autem laudantium quasi consequuntur sapiente saepe sit obcaecati consequatur magni.Labore minus libero, vel voluptatum amet dolore sapiente officia aperiam dolores tempora molestiae pariatur ? Explicabo quia ullam enim " + 
   " temporibus adipisci doloremque, illo dolorum, nesciunt sint cupiditate et nemo. \n   uas illum, culpa dolore corporis dolores provident inventore nam autem laudantium \n quasi consequuntur sapiente saepe sit obcaecati consequatur magni.Labore minus \n libero, vel voluptatum amet dolore sapiente officia aperiam dolores tempora " +
   " molestiae pariatur ? \n Explicabo quia ullam enim temporibus adipisci doloremque, illo dolorum, nesciunt sint cupiditate et nemo.uas illum, culpa dolore corporis dolores provident inventore nam autem laudantium quasi \n consequuntur sapiente saepe sit obcaecati consequatur magni.Labore minus libero, vel voluptatum amet dolore \n  " + 
   "sapiente officia aperiam dolores tempora molestiae pariatur ? Explicabo quia ullam \n enim temporibus adipisci doloremque, illo dolorum, nesciunt sint cupiditate et nemo.uas illum, \n culpa dolore corporis dolores provident inventore nam autem laudantium quasi consequuntur sapiente saepe sit obcaecati consequatur magni.Labore minus libero, " + 
   "vel voluptatum amet dolore sapiente officia aperiam dolores tempora molestiae pariatur ? Explicabo quia ullam enim temporibus adipisci doloremque, illo dolorum, nesciunt sint cupiditate et nemo. ");

                            break;

                        //Caso escolha a Divisão (/)
                        case "Cadastrar":
                            Console.WriteLine("======================= SELECIONOU CADASTRAR ==================");
                            //Opcção Voltar Texte
                            Console.WriteLine("1 - Voltar");

                            Console.Write("R: ");
                            word = Convert.ToString(Console.ReadLine());

                            if (word == "Voltar" || word == "voltar")
                            {
                                
                            }
                            break;

                        case "Consultar":
                            Console.WriteLine("==========================CONSULTAR================");
                            break;


                        //Caso o Simbolo não existir
                        default:
                            Console.WriteLine("Palavra não faz parte do meu vocabulário de Assistente Administador");
                            Console.WriteLine("==============================================");
                            break;
                    }
                }

                else
	                {
                        Console.WriteLine("Não foi direcionado para nunhuma Area");
                    }
                
            }
            else
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("BENVINDO AO SISTEMA - USÚARIO NORMAL");
                Console.WriteLine("===========================================");
            }
            Console.ReadKey();

        }
    }
}
