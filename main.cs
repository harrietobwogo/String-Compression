using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
	public int Compress(char[] chars) {
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