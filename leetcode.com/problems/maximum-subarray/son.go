package problem0053

import "fmt"

func maxSubArray(nums []int) int {
	max := nums[0]
	acc := 0
	for i := 0; i < len(nums); i++ {
		acc += nums[i]
		if max < acc {
			max = acc
		}
		if acc < 0 {
			acc = 0
		}
	}
	return max
}

func main() {
	fmt.Println(maxSubArray([]int{-2, 1, -3, 4, -1, 2, 1, -5, 4}))
}
