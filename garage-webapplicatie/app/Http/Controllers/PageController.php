<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class PageController extends Controller
{

  public function home()
  {
//    $customers = \App\Customers::all(); compact('customers')

    return view('pages.home');
  }

  public function dashboard()
  {
    return view('pages.dashboard');
  }

}
