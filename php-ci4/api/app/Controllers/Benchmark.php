<?php

namespace App\Controllers;

use App\Models\ResponseModel;
use App\Models\StudentModel;
use App\Models\ClassModel;
use App\Models\EnrollmentModel;
use CodeIgniter\RESTful\ResourceController;

class Benchmark extends ResourceController
{
	protected $format    = 'json';

	public function index()
	{
		return $this->respondCreated("Welcome to RESTFul API CI4");
	}
	public function hello()
	{
		return $this->respond(implode(' ', ["hello", "world"]));
	}

	public function compute(){
		$x = 0;
		$y = 1;
		$max = 10000 + rand(0, 500);
		for ($i = 0; $i <= $max; $i++) {
			$z = $x + $y;
			$x = $y;
			$y = $z;
		}
		return $this->respond(["status" => "Done"]);
	}

	public function simpleListing(){
		$formatResponse = new ResponseModel();
		$model = new StudentModel();
		$formatResponse->data = $model->findAll();
		return $this->respond($formatResponse);
	}

	public function complexListing(){
		//since i did not know anything yet about relation using new active directory of CI4, we will doing it manually
		//if someone knows, please make it better
		$formatResponse = new ResponseModel();
		$enrollmentModel = new EnrollmentModel();
		$formatResponse->data = [];
		foreach ($enrollmentModel->getStudentbyClass() as $item) {
			$new_item["fullname"] = $item["firstname"] . " " . $item["lastname"];
			$new_item["birtdate"] = date("d F Y",strtotime($item["birthdate"]));
			$new_item["enrollments"] = $enrollmentModel->getClassByIdStudent($item["student_id"]);
			array_push($formatResponse->data,$new_item);
		}
		return $this->respond($formatResponse);
	}
}
