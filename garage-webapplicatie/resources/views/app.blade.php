<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="{{ asset('css/app.css') }}">
    <script type="text/javascript" src="{{asset('js/jquery-3.5.1.js')}}"></script>
    <script type="text/javascript" src="{{ asset('js/functions.js') }}"></script>
    <script type="text/javascript" src="{{ asset('js/script.js') }}"></script>
    <title>@yield('title')</title>
</head>
<body>
    @include('includes.header')

    @include('includes.page-title')

    <main class="container mt-5 mb-5">
    @yield('content')
    </main>

    @include('includes.footer')
</body>
</html>
