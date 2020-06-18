<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class AppointmentStatus extends Model
{
    protected $table = 'appointment_status';

    public function status() {
        return $this->hasMany('App\Appointment');
    }
}
