package com.kulessa.KontasDB.mapper;

import com.kulessa.KontasDB.entity.User;
import com.kulessa.KontasDB.models.request.UserRequest;
import lombok.RequiredArgsConstructor;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Component
@RequiredArgsConstructor
public class UserMapper {

    public static User toUser(UserRequest request) {
        return User.builder()
                .email(request.getEmail())
                .firstName(request.getFirstName())
                .lastName(request.getLastName())
                .password(new BCryptPasswordEncoder().encode(request.getPassword()))
                .build();
    }
}
