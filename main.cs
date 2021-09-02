using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
		char[] test1=new char[]{'a','b','b','b','b','b','b','b','b','b','b','b','b'};
		char[] test2=new char[]{'a','b','b','b','b','c','c','c'};
		char[] test3=new char[]{'a'};
		char[] test4=new char[]{'a','a','b','b','b','a','a'};


		Console.WriteLine(Compress(test1));
		Console.WriteLine(Compress(test2));
		Console.WriteLine(Compress(test3));
		Console.WriteLine(Compress(test4));

  }
	public static int Compress(char[] chars) {
    if(chars.Length<2){
      return chars.Length;
    }
    int index=0;
    int i=0;
    while(i<chars.Length){
			int j=i;
			while(j<chars.Length&& chars[j]==chars[i]){
					j++;
			}
			chars[index++]=chars[i];
			if(j-i>1){
					string count=j-i+"";
					foreach(char c in count.ToCharArray()){
							chars[index++]=c;
					}
			}
			i=j;        
    }
  	return index;        
	}
}