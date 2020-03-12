<?php

namespace App\Http\Controllers;

use App\Student;
use Illuminate\Support\Facades\DB;

class BenchmarkController extends Controller
{

    public function helloWorld()
    {
        return response()->json(['Helo Wold']);
    }

    public function compute()
    {
        $x = 0;
        $y = 1;
        $max = 10000 + rand(0, 500);

        for ($i = 0; $i <= $max; $i++) {
            $z = $x + $y;
            $x = $y;
            $y = $z;
        }

        return response()->json(['status' => 'done']);
    }

    public function simpleListing()
    {
        $students = Student::select(DB::raw('CONCAT(firstname, " ", lastname) AS fullname'))->get();

        return response()->json([
            'isError' => false,
            'statusCode' => 300,
            'results' => $students
        ]);
    }

    public function complexListing()
    {
        $formatResponse = [];

        $studentByMathClass = DB::table('course_student')
            ->select(
                'students.id',
                'students.firstname',
                'students.lastname',
                'students.birthdate'
            )
            ->join('students', 'students.id', '=', 'course_student.student_id')
            ->join('courses', 'courses.id', '=', 'course_student.student_id')
            ->where('courses.title', '=', 'Math')
            ->get()->toArray();

        foreach ($studentByMathClass as $item) {
            $newItem['fullname'] = $item->firstname . ' ' . $item->lastname;
            $newItem['birthdate'] = date("d F Y", strtotime($item->birthdate));
            $newItem['enrollments'] = Student::find($item->id)->courses()->get()->toArray();
            array_push($formatResponse, $newItem);
        }

        return response()->json($formatResponse);
    }
}
