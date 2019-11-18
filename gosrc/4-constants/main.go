package main

import (
	"fmt"
	"math"
)

const s1 string = "constant 1"
const s2 = "constant 2"

func main() {
	fmt.Println(s1)
	fmt.Println(s2)

	const n = 500000000

	const d = 3e20 / n
	fmt.Println(d)

	fmt.Println(int64(d))

	fmt.Println(math.Sin(n))
}
