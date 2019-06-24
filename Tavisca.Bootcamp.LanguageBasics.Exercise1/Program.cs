using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
            // Add your code here.
            
            char []equal = {'='};
            string []arr=equation.Split(equal);
            string right=arr[1];
            char []multi = {'*'};
            int a=0,b=0,c=0;
            string []left=arr[0].Split(multi);
            string l1=left[0];
            string l2=left[1];
            for(int i=0;i<l1.Length;i++){
                if(l1[i]=='?') a=1;
            }
            for(int i=0;i<l2.Length;i++){
                if(l2[i]=='?') b=1;
            }
            for(int i=0;i<right.Length;i++){
                if(right[i]=='?') c=1;
            }
            //Console.WriteLine("a= {0}",l1 );
            if(a==1){
                int num1=Int32.Parse(l2);
                int num2=Int32.Parse(right);
                int ans=num2/num1;
                
                if(num2%num1==0){
                    int j=l1.Length-1;
                    while(ans!=0){
                        int rem=ans%10;
                        if(l1[j]=='?') return rem;
                        ans=ans/10;
                        j--;
                    }
                }
                else return -1;
            }
            else{
                    if(b==1){
                        int num1=Int32.Parse(l1);
                        int num2=Int32.Parse(right);
                        int ans=num2/num1;
                        
                        if(num2%num1==0){
                            int j=l2.Length-1;
                            while(ans!=0){
                            int rem=ans%10;
                            if(l2[j]=='?') return rem;
                            ans=ans/10;
                            j--;
                        }
                    }
                    else return -1; 
                    }
                    else{
                        int num1=Int32.Parse(l1);
                        int num2=Int32.Parse(l2);
                        int ans=num2*num1;
                            int j=right.Length-1;
                            while(ans!=0){
                            int rem=ans%10;
                            if(right[j]=='?') return rem;
                            ans=ans/10;
                            j--;
                            }
                            return -1;
                    }
                    return -1;
            }
            return -1;
           // throw new NotImplementedException();
        }
    }
}