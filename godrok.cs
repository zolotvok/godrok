using System;
using System.Collections.Generic;
using System.IO;
public class Godrok{

public static void Main(string[] args){
string file_location="/home/zolotvok/melyseg.txt";
string [] list=File.ReadAllLines(file_location);
Console.WriteLine("1. feladat");
Console.WriteLine("A fájl adatainak száma: "+list.Length);
int tavolsag=0;
Console.WriteLine("2. feladat");
Console.Write("Adjon meg egy távolságértéket! ");
tavolsag=int.Parse(Console.ReadLine());
Console.WriteLine("Ezen a helyen a felszín "+list[tavolsag]+" mélyen van.");
int hagynull=0;
double percentage=0;
foreach(var sor in list){
if( sor == "0" ){
hagynull+=1;
percentage=((double) hagynull/list.Length)*100;
}
}
Console.WriteLine("3.feladat");
Console.WriteLine("Az érintetlen terület aránya "+Math.Round(percentage,2)+"%.");
bool idk=false;
int asd=0;
//string[] geci = {"","","","","","","","","","","","","","","","","","","","","","","","",""};
int sad=0;
for (int i = 0;i<list.Length;i++){
if(list[i]!="0"){idk=true;}
if((list[i]=="0")&&(idk==true)){sad++;idk=false;}
}

string [] geci = new string[sad];
for(int i = 0; i<list.Length;i++){
if(list[i]!="0"){geci[asd]+=list[i];;idk=true;}
if(list[i]=="0"){if(idk==true){asd+=1;}idk=false;}
}
File.WriteAllLines("/home/zolotvok/godrok.txt",geci);

Console.WriteLine("5. feladat");
int anyád=0;
foreach(var fasz in geci){
if (fasz !=""){anyád+=1;}

}
Console.WriteLine("A gödrök száma: "+asd);
Console.WriteLine("6. feladat");
int kezdo=0;
int vegzo=0;
bool alma=false;
list=File.ReadAllLines(file_location);
try
{
if(list[tavolsag]=="0"){Console.WriteLine("Az adott helyen nincs gödör.");alma=true;}

for(int i = 0;i<tavolsag;i++){
if(alma==true){break;}
if(list[tavolsag-i]=="0"){kezdo=tavolsag-i+2;break;}
}
for(int i = 0;i<list.Length;i++){
if(alma==true){break;}
if(list[tavolsag+i]=="0"){vegzo=tavolsag+i;break;}
}
}
catch (System.Exception)
{
    Console.WriteLine("asdf");
}



if(alma!=true){
Console.WriteLine("a)");
Console.WriteLine("A gödör kezdete: "+kezdo+" méter, a gödör vége: "+vegzo+" méter.");
}
}
}


