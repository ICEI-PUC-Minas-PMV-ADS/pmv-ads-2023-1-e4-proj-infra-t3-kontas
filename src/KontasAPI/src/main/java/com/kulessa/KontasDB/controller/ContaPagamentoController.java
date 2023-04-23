package com.kulessa.KontasDB.controller;

import com.kulessa.KontasDB.dto.ContaPagamentoDTO;
import com.kulessa.KontasDB.entity.ContaPagamento;
import com.kulessa.KontasDB.mapper.ContaPagamentoMapper;
import com.kulessa.KontasDB.models.request.ContaPagamentoRequest;
import com.kulessa.KontasDB.models.request.UpdateContaPagamentoRequest;
import com.kulessa.KontasDB.service.ContaPagamentoService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.security.Principal;

@RestController
@RequestMapping("/api/ContaPagamentos")
@RequiredArgsConstructor
public class ContaPagamentoController {
    private final ContaPagamentoService service;

    @PostMapping
    public ResponseEntity<ContaPagamentoDTO> create(@RequestBody ContaPagamentoRequest request, Principal principal) {
        return ResponseEntity.ok(ContaPagamentoMapper.toContaPagamentoDTO(service.create(request, principal.getName())));
    }

    @GetMapping("/{id}")
    public ResponseEntity<ContaPagamentoDTO> getById(@PathVariable Integer id, Principal principal) {
        return ResponseEntity.ok(ContaPagamentoMapper.toContaPagamentoDTO(service.getById(id, principal.getName())));
    }

    @PutMapping("/{id}")
    public ResponseEntity<ContaPagamentoDTO> update(@PathVariable Integer id, @RequestBody UpdateContaPagamentoRequest request, Principal principal) {
        return ResponseEntity.ok(ContaPagamentoMapper.toContaPagamentoDTO(service.update(service.getById(id, principal.getName()), request)));
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Object> delete(@PathVariable Integer id, Principal principal) {
        service.delete(id, principal.getName());
        return ResponseEntity.ok().build();
    }
}
