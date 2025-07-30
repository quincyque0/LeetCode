public class Solution {
    private int maxOr = 0;
    private int count = 0;

    public int CountMaxOrSubsets(int[] nums) {
        maxOr = 0;
        count = 0;

        // Сначала определим максимум
        foreach (int num in nums) {
            maxOr |= num;
        }

        // Запускаем DFS
        Dfs(nums, 0, 0);

        return count;
    }

    private void Dfs(int[] nums, int index, int currentOr) {
        if (index == nums.Length) {
            // Пропускаем пустое множество
            if (currentOr == maxOr) {
                count++;
            }
            return;
        }

        // Включить nums[index] в подмножество
        Dfs(nums, index + 1, currentOr | nums[index]);

        // Не включать nums[index]
        Dfs(nums, index + 1, currentOr);
    }
}
