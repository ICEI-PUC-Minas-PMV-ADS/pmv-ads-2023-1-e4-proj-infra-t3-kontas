package com.kulessa.KontasDB.service;

import com.kulessa.KontasDB.entity.Conta;
import com.kulessa.KontasDB.models.request.ContaRequest;
import com.kulessa.KontasDB.repository.ContaRepository;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import java.math.BigDecimal;
import java.time.LocalDate;

import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.when;

@ExtendWith(MockitoExtension.class)
public class ContaServiceTest {
    @InjectMocks
    private ContaService service;

    @Mock
    private ContaRepository repository;

    private ContaRequest request;

    private Conta conta;

    @BeforeAll
    public void setup() {
        this.request = ContaRequest.builder()
                .descricao("Conta de luz")
                .valor(BigDecimal.valueOf(100.00))
                .vencimento(LocalDate.now().plusDays(5))
                .pagar(true)
                .build();

        this.conta = Conta.builder()
                .contaPagamento(null)
                .id(1)
                .descricao("Conta de luz")
                .valor(BigDecimal.valueOf(100.00))
                .pagar(true)
                .build();
    }

    @Test
    public void shouldCreateConta() {
        when
        when(repository.save(any(Conta.class))).thenReturn(conta);
    }
}
