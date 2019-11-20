package main

import "fmt"

func removeDuplicates(a []int) int {
	if len(a) == 0 {
		return 0
	}
	i := 1
	for i < len(a) {
		if a[i] == a[i-1] {
			diff := false
			for j := i + 1; j < len(a); j++ {
				if a[j-1] != a[j] {
					diff = true
				}
				a[j-1] = a[j]
			}
			if !diff {
				return i
			}
		} else {
			i++
		}
	}

	return len(a)
}
func main() {
	a1 := []int{0, 0, 1, 1, 1, 1, 2, 2, 3, 3, 4, 4}
	fmt.Println(removeDuplicates(a1), a1)

	a2 := []int{0, 0, 1, 1, 1, 1, 2, 2, 3, 3, 4, 4}
	fmt.Println(removeDuplicates2(a2), a2)
}
