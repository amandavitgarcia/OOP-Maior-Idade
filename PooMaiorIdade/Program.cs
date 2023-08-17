namespace PooMaiorIdade
{
   class Program
   {
        static void Main(String[] args)
        {
            string nome = "";
            int idade = 0;
            Console.WriteLine("------Maior Idade------");

            //Instanciando  
            Pessoa pessoa1 = new Pessoa(nome, idade);
            Pessoa pessoa2 = new Pessoa(nome,idade);
            Pessoa pessoa3 = new Pessoa(nome,idade);

            //Dados 1ª pessoa
            Console.Write("Informe o nome da 1ª pessoa: ");
            pessoa1.NomePessoa = Console.ReadLine(); //obtendo valor por meio do console e armazenando direto da propriedade nome da classe pessoa

            Console.Write($"Informe a idade de {pessoa1.NomePessoa}: ");
            pessoa1.IdadePessoa = int.Parse(Console.ReadLine());

            //Dados 2º pessoa
            Console.Write("Informe o nome da 2ª pessoa: ");
            pessoa2.NomePessoa= Console.ReadLine();

            Console.WriteLine($"Informe a idade de {pessoa2.NomePessoa}: ");
            pessoa2.IdadePessoa = int.Parse(Console.ReadLine());

            //Dados 3ª pessoa
            Console.Write("Informe o nome da terceira pessoa: ");
            pessoa3.NomePessoa = Console.ReadLine();

            Console.Write($"Informe a idade de {pessoa3.NomePessoa}: ");
            pessoa3.IdadePessoa= int.Parse(Console.ReadLine());

            //Verificando + velho
            if(pessoa1.IdadePessoa >  pessoa2.IdadePessoa && pessoa1.IdadePessoa > pessoa3.IdadePessoa)
            {
                Console.WriteLine($"O idoso é: ");
                pessoa1.ExibirDados();
            }
            else
            {
                if (pessoa2.IdadePessoa > pessoa1.IdadePessoa && pessoa2.IdadePessoa > pessoa3.IdadePessoa)
                {
                    Console.WriteLine($"O idoso é: ");
                    pessoa2.ExibirDados();
                }
                else
                {
                    if (pessoa3.IdadePessoa > pessoa1.IdadePessoa && pessoa3.IdadePessoa > pessoa2.IdadePessoa)
                    {
                        Console.WriteLine($"O idoso é: ");
                        pessoa3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine($"Todos possuem a mesma idade.");
                        pessoa1.ExibirDados();
                    }
                }
            }
    
            //    if(idade != idade2 && idade != idade3)
            //    {
            //        Console.WriteLine($"{nome} é o mais velho.");
            //    }
            //    if(idade2 != idade && idade2 != idade3)
            //    {
            //        Console.WriteLine($"{nome2} é o mais velho");
            //    }
            //    if(idade3 != idade && idade3 != idade2)
            //    {
            //        Console.WriteLine($"{nome3} é o mais velho.");
            //    }
            //    if(idade == idade2)
            //    {
            //        Console.WriteLine($"{nome} e {nome2} possuem a mesma idade.");
            //    }
            //    if(idade2 == idade3)
            //    {
            //        Console.WriteLine($"{nome2} e {nome3} possuem a mesma idade");
            //    }
            //    if(idade3 == idade)
            //    {
            //        Console.WriteLine($"{nome} e {nome3} possuem a mesma idade");
            //    }
            //    else
            //    {
            //        Console.WriteLine("?");
            //    }

        }
   }
}