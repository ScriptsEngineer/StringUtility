using System;

namespace StringUtility
{
    public class StringUtils
    {

        public static bool StartWithUpper(string str){

            if(String.IsNullOrWhiteSpace(str)){
                return false;
            }

            Char ch = str[0];
            return Char.IsUpper(ch);
                
        }

    }
}
