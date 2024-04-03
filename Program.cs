using System;
 
class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Digite a nota do 1 Bimestre");
    double nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso para a nota do 1 Bimestre");
    int peso1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a nota do 2 Bimestre");
    double nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso para a nota do 2 Bimestre");
    int peso2 = int.Parse(Console.ReadLine());
    
    double md = (nota1*peso1 + nota2*peso2)/(peso1+peso2);

    Console.WriteLine("A sua media e: {0}", md);
    
    if(md >= 6.0){
      Console.WriteLine("Parabens, voce foi aprovador.");
    }else if(md < 6.0 && md > 2.0){
      Console.WriteLine("Infelizmente voce esta em recuperacao");
    }else{
      Console.WriteLine("Infelizmente voce foi reprovado");
    }
  }
}