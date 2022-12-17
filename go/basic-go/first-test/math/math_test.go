package math

import "testing"

func Test_GivenFourAndSix_WhenAdding_Sum10(t *testing.T) {
	actual := Add(4, 6)
	expected := 10

	if actual != expected {
		t.Errorf("actual: %d, expected %d", actual, expected)
	}
}

func Test_GivenMultipleAdditions_WhenAdding_ThenExpectedValue(t *testing.T) {
	type additionTest struct {
		arg1        int
		arg2        int
		expectedSum int
	}

	additionsTests := []additionTest{
		{arg2: 3, arg1: 2, expectedSum: 5},
		{6, 2, 8},
		{-10, 2, -8},
	}

	for _, test := range additionsTests {
		if actual := Add(test.arg1, test.arg2); actual != test.expectedSum {
			t.Errorf("actual: %d, expected %d", actual, test.expectedSum)
		}
	}
}
