package com.example.feignservice;

import org.springframework.stereotype.Component;


//断路器
@Component
public class SchedualServiceHiHystric implements iHIservice.SchedualServiceHi {
    @Override
    public String sayHiFromClientOne(String name) {
        return "sorry "+name;
    }
}