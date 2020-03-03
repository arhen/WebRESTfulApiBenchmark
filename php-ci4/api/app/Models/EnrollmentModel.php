<?php

namespace App\Models;

use CodeIgniter\Model;

class EnrollmentModel extends Model
{
	protected $table      = 'enrollment';
	protected $primaryKey = 'enrollment_id';
	protected $returnType = 'array';

	public function getStudentbyClass(){
		$db      = \Config\Database::connect();
		$builder = $db->table('enrollments');

		$builder->select('students.student_id,students.firstname,students.lastname,students.birthdate');
		$builder->join('classes', 'classes.class_id = enrollments.class_id');
		$builder->join('students', 'students.student_id = enrollments.student_id');
		$builder->where("classes.title", "Math");
		$query = $builder->get()->getResultArray();

		return $query;
	}

	public function getClassByIdStudent($id){
		$db      = \Config\Database::connect();
		$builder = $db->table('enrollments');

		$builder->select('classes.class_id,classes.title,classes.description');
		$builder->join('classes', 'classes.class_id = enrollments.class_id');
		$builder->where("enrollments.student_id", $id);
		$query = $builder->get()->getResultArray();
		return $query;
	}
}
