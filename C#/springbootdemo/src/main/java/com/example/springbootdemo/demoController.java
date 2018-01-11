package com.example.springbootdemo;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class demoController {

    @RequestMapping(value = "Hello", method = RequestMethod.GET)
    public String Hello(){
        return "hello world";
    }
}
