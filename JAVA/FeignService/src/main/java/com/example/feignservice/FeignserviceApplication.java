package com.example.feignservice;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.client.discovery.EnableDiscoveryClient;
import org.springframework.cloud.netflix.feign.EnableFeignClients;
import org.springframework.cloud.netflix.feign.FeignClient;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;


@EnableDiscoveryClient
@EnableFeignClients
@SpringBootApplication
public class FeignserviceApplication {

	public static void main(String[] args) {
		SpringApplication.run(FeignserviceApplication.class, args);
	}
}
