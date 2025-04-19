public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string sp){
        return str.Split(sp)[1];
    }

    public static string SubstringBetween(this string str, string starts, string ends){
        int desde = str.IndexOf(starts) + starts.Length;
        int hasta = str.IndexOf(ends) - desde;
        return str.Substring(desde, hasta);
    }
    
    public static string Message(this string str){
        return str.SubstringAfter(": ");
    }
    
    public static string LogLevel(this string str){
        return str.SubstringBetween("[", "]");
    }

}