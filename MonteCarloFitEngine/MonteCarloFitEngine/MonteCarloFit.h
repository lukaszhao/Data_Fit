#pragma once
#include <vector>
#include <string>


class MonteCarloFit
{
private:
	std::vector<double> d_para;
	std::vector<std::string> d_para_name;

	std::vector<double> d_dpara;

	std::vector<double> d_datapoints_x;
	std::vector<double> d_datapoints_y;

	int d_num_para;

	
public:
	MonteCarloFit() {
		// set the number of parameters
		d_num_para = 3;
		for (int i = 0; i < d_num_para; ++i) {
			d_para.push_back(1);
			d_dpara.push_back(1);
		}
	}

	virtual ~MonteCarloFit() {}

	double f(double x, double a, double b, double c) {	// equation to fit, number of parameters should match d_para
		return a*x*x + b*x + c;
	}



};

