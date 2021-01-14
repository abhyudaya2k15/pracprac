#!/usr/bin/env dotnet-script

using System;
var watch = new System.Diagnostics.Stopwatch();

watch.Start();
string b = "Hocus Pocus ";
for(int i=0; i< 5000; i++)
{
b =  b + "Hocus Pocus " ; 
}
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

watch.Restart();
stringb c = new stringb("Hocus Pocus ");
for(int i=0; i< 5000; i++)
{
c = c.append("Hocus Pocus ");
}
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);

if(b.Equals(c.ToString()))
{
	Console.WriteLine("Yep");
}
else
{
	Console.WriteLine("Nope");
}

class stringb
{
	int cap,used;
    char[] arr;
	public stringb(string array)
	{
		cap=16;
		used=0;
		arr= new char[cap];
		this.append(array);
	}
	stringb(char[] array, int capa ,int useda)
	{
		arr=array;
		cap=capa;
		used=useda;
	}
	public override string ToString()
	{
		arr = arr.Where(x => (char.IsLetter(x) || char.IsWhiteSpace(x))).ToArray();
		return new String(arr);
	}
	
	public stringb append(string a)
	{
		int index = 0;
		int len = a.Length;
		while(index < len)
		{
			if(used>=cap)
			{
				cap= cap*2;
				char[] temp =  new char[cap];
				int indtemp=0;
				while(indtemp<cap/2)
				{
					temp[indtemp]=arr[indtemp++];
				}
				arr = temp;
				used=indtemp;
			}
			arr[used++]=a[index++];
		}
		return this;
	}
}
	