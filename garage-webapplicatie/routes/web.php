<?php

use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Auth::routes();

Route::get('/', 'PageController@home');
Route::get('/home', 'PageController@home');
Route::get('/dashboard', 'PageController@dashboard')->middleware('auth');
Route::get('/afspraak-maken', 'PageController@appointment')->middleware('auth');
Route::get('/download-invoice/{id}', 'PageController@downloadInvoice')->middleware('auth');
Route::get('/betaal/{id}', 'PageController@payment')->middleware('auth');

Route::post('/make-appointment', 'PostController@makeAppointment');
Route::post('/factuur', 'PostController@invoice');
Route::post('/payment', 'PostController@payment');
Route::post('/post-review', 'PostController@postReview');
