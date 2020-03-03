<?php

namespace App\Models;

use CodeIgniter\Model;

class ClassModel extends Model
{
	protected $table      = 'classes';
	protected $primaryKey = 'class_id';
	protected $returnType = 'array';
}
