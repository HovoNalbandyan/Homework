﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "աբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցուփքևօֆ";

            string str1 = "abcdefghjklmnopqrstuvwxyz";
            Dictionary<string, string> lettercollection = new Dictionary<string, string>();

            lettercollection.Add("a", "ա");
            lettercollection.Add("b", "բ");
            lettercollection.Add("c", "ց");
            lettercollection.Add("d", "դ");
            lettercollection.Add("e", "ե");
            lettercollection.Add("f", "ֆ");
            lettercollection.Add("g", "գ");
            lettercollection.Add("h", "հ");
            lettercollection.Add("j", "ջ");
            lettercollection.Add("k", "կ");
            lettercollection.Add("l", "լ");
            lettercollection.Add("m", "մ");
            lettercollection.Add("n", "ն");
            lettercollection.Add("o", "օ");
            lettercollection.Add("p", "պ");
            lettercollection.Add("q", "ք");
            lettercollection.Add("r", "ռ");
            lettercollection.Add("s", "ս");
            lettercollection.Add("t", "տ");
            lettercollection.Add("u", "ու");
            lettercollection.Add("v", "վ");
            lettercollection.Add("w", "ո");
            lettercollection.Add("x", "խ");
            lettercollection.Add("y", "յ");
            lettercollection.Add("z", "զ");

           // lettercollection.Add("b", "է");
            lettercollection.Add("dz", "ձ");
            lettercollection.Add("ev", "և");
            //lettercollection.Add("r", "ր");
            lettercollection.Add("ch", "չ");
            //lettercollection.Add("ch", "ճ");
            lettercollection.Add("jh", "ժ");
            lettercollection.Add("gh", "ղ");
            lettercollection.Add("sh", "շ");



            string a = Console.ReadLine();
            string newstr = "";
            for(int i = 0; i < a.Length; i++)
            {
                newstr = newstr + lettercollection[a[i].ToString()];
            }
            Console.WriteLine(newstr);
            Console.ReadKey();


        }
    }
}