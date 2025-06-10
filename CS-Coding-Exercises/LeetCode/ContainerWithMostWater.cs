namespace LeetCode;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int x = 0;
        int y = height.Length - 1;

        while (x < y)
        {
            int distance = y - x;
            int minHeight = height[x];
            if (minHeight > height[y])
            {
                minHeight = height[y];
                y--;
            }
            else x++;

            int area = minHeight * distance;
            if (area > maxArea)
                maxArea = area;
        }
        return maxArea;
    }
}
