package com.kulessa.KontasDB.controller;

import com.kulessa.KontasDB.dto.ContaDTO;
import com.kulessa.KontasDB.entity.Conta;
import com.kulessa.KontasDB.mapper.ContaMapper;
import com.kulessa.KontasDB.models.request.ContaRequest;
import com.kulessa.KontasDB.service.ContaService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.security.Principal;
import java.util.List;

@RestController
@RequestMapping("/api/Contas")
@RequiredArgsConstructor
public class ContaController {
    private final ContaService service;

    @PostMapping
    public ResponseEntity<ContaDTO> create(@RequestBody ContaRequest request, Principal principal) {
        return ResponseEntity.ok(ContaMapper.toContaDTO(service.create(request, principal.getName())));
    }

    @GetMapping
    public ResponseEntity<List<ContaDTO>> getAll(Principal principal) {
        return ResponseEntity.ok(service.getAll(principal.getName()).stream().map(ContaMapper::toContaDTO).toList());
    }

    @GetMapping("/{id}")
    public ResponseEntity<ContaDTO> getById(@PathVariable Integer id, Principal principal) {
        return ResponseEntity.ok(ContaMapper.toContaDTO(service.getById(id, principal.getName())));
    }

    @PutMapping("/{id}")
    public ResponseEntity<ContaDTO> update(@PathVariable Integer id, @RequestBody ContaRequest request, Principal principal) {
        return ResponseEntity.ok(ContaMapper.toContaDTO(service.update(service.getById(id, principal.getName()), request)));
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Object> delete(@PathVariable Integer id, Principal principal) {
        service.delete(id, principal.getName());
        return ResponseEntity.ok().build();
    }
}
