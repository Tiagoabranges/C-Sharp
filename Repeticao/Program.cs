namespace WorkTools;
public static class  NumbersTools
{
    public static int IndexOf(int[] numbers, int value)
    {     
        var position = -1;

        for(int i=0; i < numbers.Count(); i++)
        {        
            if(numbers[i] == value)
            {
                position = i;
                break;
            }        
        }
        
        return position;
    }
}