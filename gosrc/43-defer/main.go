package main

import "fmt"

func bye() {
	fmt.Println("bye!")
}

func main() {
	defer bye()
	fmt.Println("hi!")
}
