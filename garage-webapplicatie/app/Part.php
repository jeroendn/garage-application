<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Part extends Model
{
    protected $table = 'parts';

    public function appointments() {
        return $this->belongsToMany('App\Appointment');
    }
}
