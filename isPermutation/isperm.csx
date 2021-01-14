string a = "lolwaaa",b = "lolvaaa";
Console.WriteLine((isPerm(a,b))?"Perma":"Noprerma");
bool isPerm(string a, string b)
{
    if(a.Length!=b.Length||a.Length>128||b.Length>128)
        return false;
    Dictionary<char,int> map =  new Dictionary<char,int>();
    for (int i=0; i<a.Length; i++)
    {
        if(!map.ContainsKey(a[i]))
            map[a[i]]=1;
        else
            map[a[i]]++;
    }
    for (int i=0; i<b.Length; i++)
    {
        if(map.ContainsKey(b[i]))
        {
            map[b[i]]--;
            if(map[b[i]]==0)
                map.Remove(b[i]);
        }
        else
            return false;
    }
    return true;
}
