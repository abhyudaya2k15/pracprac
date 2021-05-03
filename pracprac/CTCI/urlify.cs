namespace url
{
  public static class urlify {
      public static char[] replaceSpace (char[] text, int length)
      {
          int len =  text.Length,spaces = 0;
          for(int i=0; i<len; i++)
          {
            if(text[i] == ' ')
            {
                spaces++;
            }
          }
          
          for(int i = length; i>=0; i--)
          {
              if(text[i] != ' ')
              {
                  text[i+spaces*2] = text[i];
              }
              else
              {
                  spaces--;
                  text[i+spaces*2]='%';
                  text[i+spaces*2+1]='2';
                  text[i+spaces*2+2]='0';
              }
          }
        return text;
      }
  }  
}