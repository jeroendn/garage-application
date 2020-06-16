<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Schema;

class CreateUsersTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('users', function (Blueprint $table) {
            $table->id();
            $table->string('firstname');
            $table->string('lastname');
            $table->string('email')->unique();
            $table->timestamp('email_verified_at')->nullable();
            $table->string('password');
            $table->rememberToken();
            $table->string('street')->default('');
            $table->integer('street_number')->default(0);
            $table->string('zip')->default('');
            $table->timestamps();
        });

        DB::table('users')->insert([
            ['firstname' => 'Admin', 'email' => 'admin@mail.com', 'password' => '$2y$10$f6OlWC5WxFZx1lt3bs3RR.OVnXqUKHBm300DruB07P43jSDRQPVlW']
        ]);
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('users');
    }
}
