using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorldCore
{
    public class Engene
    {
        public string isThisCorectStreeng(string patern)
        {
            var copyPatern = patern;
            var regular = new Regex(@"\d{1,}x\d{1,} [\(+\d{1}, \d{1}\)]{2,}").Replace(copyPatern, "0");
            if (regular == "0")
            {
                return patern;
            }else{
                return null;
            }
        }
        public int[] convertToArr(string patern)
        {
            string str_copy = patern;
            var replace_patern = new Regex(@"\D").Replace(patern, " ").Replace("  ", " ");
            int zeroCount = 0;
            var regex_copy= new Regex(@"\D").Replace(str_copy, "");
            int[] array = new int[regex_copy.Length];
            int size = 0;
                for (int i = 0, jjj = 0; i < replace_patern.Length; i++)
                {
                    int count = 0;
                    if (replace_patern[i] == '0')
                        zeroCount += 1;
                    while (replace_patern[i] != ' ')
                    {
                        array[jjj] += (replace_patern[i] - '0') * (int)Math.Pow(10, count);
                        i++;
                        count++;
                    }
                    string revers = array[jjj].ToString();
                    char[] array_for_reverse = revers.ToCharArray();
                    Array.Reverse(array_for_reverse);
                    revers = new String(array_for_reverse);
                    array[jjj] = Convert.ToInt32(revers);
                    jjj++;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != 0)
                        size++;
                }
                int[] copy_array = new int[size + zeroCount];
                for (int i = 0; i < size + zeroCount; i++)
                {
                copy_array[i] = array[i];
                }
                foreach (var item in copy_array)
                {
                   // Console.WriteLine(item);
                }
                return copy_array;
        }
        public bool isCoretSize(string patern)
        {
            int[] arr = convertToArr(patern);
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > arr[0] && arr[i] > arr[1])
                    return false;
            }
            return true;
        }
        public string transformToString(string patern)
        {
            string main_str = "";
            int[] arr = convertToArr(patern);
            int[] copy_arr = new int[2] {0,0};
            if (isCoretSize(patern) == true && isThisCorectStreeng(patern) != null)
            {
                for (int i = 2; i < arr.Length-1; i+=2)
                {
                    int copyi = arr[i];
                    int copyi1 = arr[i+1];
                    if (arr[i] > copy_arr[0])
                    {
                        while(arr[i] > copy_arr[0])
                        {
                            arr[i]--;
                            main_str += "E";
                        }
                    }
                    else if (arr[i] < copy_arr[0])
                    {
                        while (arr[i] < copy_arr[0])
                        {
                            arr[i]++;
                            main_str += "W";
                        }
                    }
                    if (arr[i+1] > copy_arr[1])
                    {
                        while (arr[i+1] > copy_arr[1])
                        {
                            arr[i+1]--;
                            main_str += "N";
                        }
                        main_str += "d";
                    }
                    else if(arr[i+1] < copy_arr[1])
                    {
                        while (arr[i+1] < copy_arr[1])
                        {
                            arr[i+1]++;
                            main_str += "S";
                        }
                        main_str += "d";
                    }
                    copy_arr[0] = copyi;
                    copy_arr[1] = copyi1;
                }
                return main_str; 
            }
            else
            {
                return "Ne poluchilos";
            }
        }
        public string Run(string patern) // 5x5 - MapSize (1,3) - first dot place - (4,4) end dot;
        {
            return "ENNNDEEEND";
        }
    }
}
