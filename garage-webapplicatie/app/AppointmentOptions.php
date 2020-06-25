<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class AppointmentOptions extends Model
{
    public function option() {
        return $this->hasMany('App\Appointment');
    }
}
