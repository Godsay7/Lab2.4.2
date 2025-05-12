#include <iostream>
#include <cmath>
#include <stdexcept> 
#include "Expression.h"
#include "Sqrt.h"

Expression::Expression()
	: a(0), b(0), c(0), d(0)
{ }

Expression::Expression(double a, double b, double c, double d)
	: a(a), b(b), c(c), d(d)
{ }

Expression::Expression(const Expression& other)
	: a(other.a), b(other.b), c(other.c), d(other.c)
{ }

double Expression::getA() const { return a; };
double Expression::getB() const { return b; };
double Expression::getC() const { return c; };
double Expression::getD() const { return d; };

void Expression::setVariables(double A, double B, double C, double D)
{
	a = A;
	b = B;
	c = C;
	d = D;
}

double Expression::evaluate() const {
	double result =  (1 + a - b / 2) / (Sqrt::sqrt(c, d) + a / b);
	if (b == 0) { throw std::runtime_error("Division by 0"); }
	if ((24 + d - c) <= 0) { throw std::runtime_error("The radical expression is less than 0"); }
	if ((std::sqrt(24 + d - c) + a / b) == 0) { throw std::runtime_error("Division by 0"); }

	return result;
}