<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateAppointmentsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('appointments', function (Blueprint $table) {
            $table->id();
            $table->unsignedBigInteger('user_id');
            $table->foreign('user_id')->references('id')->on('users');
            $table->unsignedBigInteger('option_id');
            $table->foreign('option_id')->references('id')->on('appointment_options');
            $table->mediumText('comment')->default('');
            $table->string('licence_plate');
            $table->unsignedBigInteger('status_id')->default(1);
            $table->foreign('status_id')->references('id')->on('appointment_status');
            $table->unsignedBigInteger('mechanic_id')->nullable();
            $table->foreign('mechanic_id')->references('id')->on('employees');
            $table->double('hours')->default(0);
            $table->double('total_price')->default(0);
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('appointments');
    }
}
