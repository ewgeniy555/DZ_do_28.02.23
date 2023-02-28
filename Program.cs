internal class Program
{
    private static void Main(string[] args)
    {
        
        int a=0;
        Console.WriteLine("Задача 27:метод который принимает на вход число и выдаёт сумму цифр в числе.");
        int summ(int a){

           if(a<0){a=-1*a;}
        int  d,d1=1, c, index=-1;int b ,e,sum=0;
        int[] discharge = new int[10];
        if (a >= 10 & a < 100) { 
            d = 10;e=2;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
               
            }}
        if (a >= 100& a < 1000 ) { 
            d = 100;e=3;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
                
            }}
        if (a >= 1000 & a < 10000) { 
            d = 1000;e=4;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
               
            }}
        if (a >= 10000 & a<100000)
        {
            d = 10000;e=5;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
               
            }
            
        }
        if (a >= 100000 & a < 1000000) {
            d = 100000;e=6;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
                
            } }
        if (a >= 1000000 & a < 10000000) { 
            d = 1000000;e=7;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
              
            }}
        if (a >= 10000000 & a < 100000000) {
            d =  10000000;e=8;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
              
            } }
        if (a >= 100000000 & a < 1000000000) { 
            d =  100000000;e=8;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
            
            }}
        if (a >= 1000000000 ) { 
            d =  1000000000;e=9;
            for (b= e; b > 0; b--)
            {
                c = a / d;
                 d = d / 10;
                 c=c%(d1*10);
                 index++;
                discharge[index] = c;                
            } 
            index=index+1;
            for (; b <= e; b++){
                sum=sum+ discharge[index];
                index--;
               
            }}
    return sum ;
    }
    
    a = int. Parse (Console.ReadLine());
    summ(a);
    a=summ(a);
    Console.WriteLine(a);
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Console.WriteLine(" метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.нельзя использовать Math.Pow");
   
    double stpen(double a,int b){
        double c=a;
        for(;b>1;b--){a=a*c;}
        return a;
    }
    Console.WriteLine("в ведите число возводимое в степень");
     double a1 = double.Parse (Console.ReadLine());
     Console.WriteLine("введите число возводящее в степень");
     int b =int.Parse(Console.ReadLine());
     stpen(a1,b);
     a1=stpen(a1,b);
     Console.WriteLine(a1);
     ///////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Задача 29:метод, который задаёт массив из N элементов и выводит их на экран.");
          static int rd () {
              
       Random rnd=new Random();
        int a = rnd.Next(1,90);
             return a;
             }
             
          Console.WriteLine("==========");
             
            Console.Write("задайте длинну массива");
            int index=int.Parse( Console.ReadLine()), indexm ; 
            int [] mas = new int [index];
			arr(index);
			int arr( int index){
            indexm=index-1;
            int a;
           while(indexm>=0){
		   	a=rd();
		   	mas[indexm]=a;
				indexm--;
				}
               indexm=index-1;
                for(;indexm>=0;indexm--)
				{
					int g;
					g=mas[indexm];
				Console.WriteLine(g);}
                return 0;}



    }
}
  

