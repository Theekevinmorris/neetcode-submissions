class Solution {
  twoSum(nums, target) {
    const map = {};
    for (let i = 0; i < nums.length; i++) {
      map[nums[i]] = i;
    }
    
    for (let i = 0; i < nums.length; i++) {
      const complement = target - nums[i];
      if (complement in map && map[complement] !== i) {
        return [i, map[complement]];
      }
    }
    return [];
  }
}
