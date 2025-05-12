#pragma once

class Expression {
private: 
	double a, b, c, d;

public: 
	Expression();
	Expression(double a, double b, double c, double d);
	Expression(const Expression& other);

	double getA() const;
	double getB() const;
	double getC() const;
	double getD() const;

	void setVariables(double A, double B, double C, double D);

	double evaluate() const;

	
};
