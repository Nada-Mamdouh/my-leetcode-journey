# New Solution using Hashmap as well for Manara ^^
on 7th July 2024
​
## Old solution using Hashmap
/**Implementing using HashMap AKA Dictionary in C#
** The dictionary will be empty and while looping over the array, we'll
** check if the difference between target and current iterated
number then return array with the indecis otherwise add the number      and  keep iterating, once done and no two different numbers add to
the target then return null or just return;
Time complexity: O(n), Space Complexity: O(n)
**/
Dictionary<int, int> dict = new Dictionary<int, int>();
for(int i = 0; i< nums.Length;i++){
int diff = target - nums[i];
if(dict.ContainsKey(diff)){
return new[]{dict[diff],i};
}
//If the key doesn't exist, it'll add it, otherwise it will update.
dict[nums[i]] = i;
}
return null;