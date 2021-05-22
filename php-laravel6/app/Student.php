<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Student extends Model
{
    protected $fillable = ['firtsname', 'lastname', 'birthdate'];

    public function courses()
    {
        return $this->belongsToMany(Course::class);
    }
}
