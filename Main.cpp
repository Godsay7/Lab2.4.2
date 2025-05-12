#include <iostream>
#include "Expression.h"

int main() {
    Expression arr[]{
    Expression(8, 3, 8, 5),
    Expression(1, 9, 5, 4),
    Expression(6, 2, 10, 5),
    };

    for (int i = 0; i < 3; i++) {
        try {
            double result = arr[i].evaluate();
            std::cout << "Result: " << result << std::endl;
        }
        catch (const std::runtime_error error) {
            std::cout << "Error: " << error.what() << std::endl;
        }
    }
	return 0;
}