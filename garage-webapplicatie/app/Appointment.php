<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Appointment extends Model
{
    public function status() {
        return $this->belongsTo('App\AppointmentStatus');
    }

    public function option() {
        return $this->belongsTo('App\AppointmentOptions');
    }

    public function user() {
        return $this->belongsTo('App\User');
    }

    public function parts() {
        return $this->belongsToMany('App\Part')->withPivot('amount', 'price_per_piece');
    }
}
