package main

func removeDuplicates2(nums []int) int {
	j := 1
	for i := 1; i < len(nums); i++ {
		if nums[i-1] != nums[i] {
			nums[j] = nums[i]
			j++
		}
	}
	return j
}
