public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows)
        return s;

        List<char>[] rows = new List<char>[numRows];
        for (int i = 0; i < numRows; i++)
            rows[i] = new List<char>();

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            rows[currentRow].Add(c);

            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;

            currentRow += goingDown ? 1 : -1;
        }

        StringBuilder sb = new StringBuilder();
        foreach (var row in rows)
            sb.Append(row.ToArray());
        
        return sb.ToString(); 
    }
}